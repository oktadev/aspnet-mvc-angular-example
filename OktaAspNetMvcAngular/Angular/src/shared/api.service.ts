import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import JoggingRecord from './JoggingRecord';

@Injectable()
export default class ApiService {
  public API = 'http://localhost:8080/api';
  public JOGGING_RECORDS_ENDPOINT = `${this.API}/joggingrecords`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Array<JoggingRecord>> {
    return this.http.get<Array<JoggingRecord>>(this.JOGGING_RECORDS_ENDPOINT);
  }
}
