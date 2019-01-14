import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class HttpService {

  constructor(private _http: HttpClient) { }

  apiBaseUrl = 'http://localhost:51756/api/';



  public post(resource: string, data: Object) {
    const request = `${this.apiBaseUrl}${resource}`;

    this._http.post(request, data).subscribe(result => {
    });
  }
}
