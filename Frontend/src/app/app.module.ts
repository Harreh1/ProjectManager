import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { TaskContainerComponent } from './task-container/task-container.component';
import { TaskListItemComponent } from './task-container/task-list-item/task-list-item.component';
import { TaskExpandedComponent } from './task-container/task-expanded/task-expanded.component';

import { TaskDetailService } from './shared/task-detail.service';


@NgModule({
  declarations: [
    AppComponent,
    TaskContainerComponent,
    TaskListItemComponent,
    TaskExpandedComponent,
    
  ],
  imports: [
    BrowserModule,
    AngularFontAwesomeModule,
    HttpClientModule
    
  ],
  providers: [TaskDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
