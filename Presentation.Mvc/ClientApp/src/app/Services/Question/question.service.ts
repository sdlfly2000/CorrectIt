import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { QuestionModel } from './Models/question.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  public retrieveQuestions(): Observable<QuestionModel[]> {
    return this.http.get<QuestionModel[]>(this.baseUrl + 'api/Question/Get');    
  }
}
