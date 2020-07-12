import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import 'rxjs/add/operator/map';

@Injectable()
export class BarChartService {

  constructor(private _http: HttpClient) { }

  getBar() {
    return this._http.get("https://localhost:5001/v1/Grafico")
      .map(result => result);
  }
}
