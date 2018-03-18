import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { } from 'rxjs/Observable/of';
import { Observable } from 'rxjs/Observable';
import { SleepService } from '../../../core/services/sleep.service';
import { Subject } from 'rxjs/Subject';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

@Injectable()
export class GiantBombApiImportService {

  private url = 'https://www.giantbomb.com/api/';
  private apiKey = '1c081c2304d40fa6586ba05fb7d5c00a6851faee';

  private numberOfPageResults = 0;
  private numberOfTotalResults: number;

  constructor(
    private _http: HttpClient,
    private _sleepService: SleepService
  ) { }

  get(resource: string, filters?: [{ key, value }]) {
    console.log(`Getting requested ${resource} data...`);

    const request = this.buildRequest(resource, filters, 0);

    return this._http.jsonp(request, 'callback');
  }

  getAll(resource: string, filters?: [{ key, value }], offset = 0): Observable<any> {

    const subject = new Subject<any>();
    this.getPageRecursive(subject, resource, filters, offset);

    return subject.asObservable();
  }

  private getPageRecursive(subject: Subject<any>, resource: string, filters: [{ key, value }], offset = 0) {

    const request = this.buildRequest(resource, filters, offset);

    console.log(`Getting requested ${resource} data with offset ${offset}`);
    console.log(request);

    this._http.jsonp(request, 'callback').subscribe(data => {

      console.log(`Got reaults ${offset} to ${offset + data['number_of_page_results']} out of ${data['number_of_total_results']}`);

      offset += +data['number_of_page_results'];

      this.numberOfTotalResults = +data['number_of_total_results'];

      subject.next(data['results']);

      if (offset < this.numberOfTotalResults) {
        this._sleepService.sleep(1000);
        this.getPageRecursive(subject, resource, filters, offset);
      }
    });
  }

  private buildRequest(resource: string, filters: [{ key, value }], offset: number) {
    return `${this.url}${resource}/?api_key=${this.apiKey}&${this.parseFitlers(filters)}` +
      `&format=jsonp&json_callback=JSONP_CALLBACK&offset=${offset}`;
  }

  private parseFitlers(filters?: [{ key, value }]): string {
    if (filters) {
      let filterString = 'filter=';

      for (const filter of filters) {
        filter.value.forEach(element => {
          filterString += `${filter.key.toString()}:${element.toString()},`;
        });
      }
      return filterString;
    }
    return '';
  }
}
