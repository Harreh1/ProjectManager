import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TaskDetail } from './task-detail.model';

@Injectable({
  providedIn: 'root'
})
export class TaskDetailService {
  formData: TaskDetail;
  apiURL: string = "http://localhost:53352/api";
  list: TaskDetail[];

  constructor(private http: HttpClient) { }

  postTaskDetail(formData: TaskDetail){
    return this.http.post(this.apiURL + '/TaskDetail', formData)
  }

  refreshList(){
    this.http.get(this.apiURL + '/TaskDetail')
    .toPromise()
    .then(res => this.list = res as TaskDetail[]);
  }
}
