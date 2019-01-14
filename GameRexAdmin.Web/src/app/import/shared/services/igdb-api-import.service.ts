import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Subject } from 'rxjs/Subject';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class IgdbApiImportService {

  endpoint = 'https://api-endpoint.igdb.com/';
  apiKey = '4d16cc9bb862bdd4e777fae4344be77a';

  limit = 3000;

  headers: HttpHeaders = new HttpHeaders()
    .set('user-key', this.apiKey)
    .set('Accept', 'application/json');

  constructor(private _http: HttpClient) {
   }

   get(resource: string, filters?: [{ key, value }]) {
    // console.log(`Getting requested ${resource} data...`);

    // const request = this.buildRequest(resource, 1);

    // return this._http.get(request, {headers: this.headers});
  }

  getAll(resource: string): Observable<any> {

    const subject = new Subject<any>();

    this._http.get(this.buildScrollRequest(resource), {observe: 'response'}).subscribe( response => {
       const nextPageRequest = response.headers.get('X-Next-Page');
       const count = +response.headers.get('X-Count');
       const received = this.limit;

       subject.next(response.body);

       this.getPageRecursive(subject, nextPageRequest, count, received);
    });

    return subject.asObservable();
  }

  // TODO: take out recursion for performance reasons
  private getPageRecursive(subject: Subject<any>, request, count, received) {
    this._http.get(request).subscribe( response => {
      if (Math.round(count / received ) > 1) {
        subject.next(response);

        received += this.limit;
        this.getPageRecursive(subject, request, count, received);
      }
    });
  }

  private buildScrollRequest(resource) {
    const scroll = 1;
    return `${this.endpoint}${resource}/scroll=${scroll}`;
  }

}
