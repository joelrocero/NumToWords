import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import INumberToWords from '../models/NumToWordModel';

@Injectable({
  providedIn: 'root',
})
export class NumtowordsService {
  baseUrl: string = 'https://localhost:7010';

  constructor(private http: HttpClient) {}

  getWords(num: Number) {
    return this.http.get<INumberToWords>(
      `${this.baseUrl}/api/NumtoWords/${num}`
    );
  }
}
