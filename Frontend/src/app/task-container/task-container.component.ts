import { TaskDetailService } from './../shared/task-detail.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-task-container',
  templateUrl: './task-container.component.html',
  styleUrls: ['./task-container.component.css']
})
export class TaskContainerComponent implements OnInit {

  constructor(private service: TaskDetailService) { }

  ngOnInit() {
    this.service.refreshList();
  }

}
