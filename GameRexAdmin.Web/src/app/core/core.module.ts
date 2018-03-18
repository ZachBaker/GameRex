import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SleepService } from './services/sleep.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [],
  providers: [ SleepService ]
})
export class CoreModule { }
