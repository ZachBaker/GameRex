import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SleepService } from './services/sleep.service';
import { HttpService } from './services/http-service.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [],
  providers: [ SleepService, HttpService ]
})
export class CoreModule { }
