import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { QuestionModel } from './Models/question.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  constructor(private http: HttpClient) { }

  public getQuestions(baseUrl: string): Observable<QuestionModel[]> {
    return this.http.get<QuestionModel[]>(baseUrl + 'api/Question/Get');    
  }
}
