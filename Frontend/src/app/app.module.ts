import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

import { AppComponent } from './app.component';
import { TaskDetailsComponent } from './task-details/task-details.component';
import { TaskContainerComponent } from './task-container/task-container.component';
import { TaskListItemComponent } from './task-container/task-list-item/task-list-item.component';
import { TaskExpandedComponent } from './task-container/task-expanded/task-expanded.component';

@NgModule({
  declarations: [
    AppComponent,
    TaskDetailsComponent,
    TaskContainerComponent,
    TaskListItemComponent,
    TaskExpandedComponent
  ],
  imports: [
    BrowserModule,
    AngularFontAwesomeModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
