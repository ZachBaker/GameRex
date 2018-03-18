import { Injectable } from '@angular/core';

// Need and enforced cooldown for external API calls

@Injectable()
export class SleepService {

  constructor() { }

  sleep(milliseconds: number) {
    console.log(`Wow that was rough.\nTaking a ${milliseconds} millisecond nap`);

    const start = new Date().getTime();
    for (let i = 0; i < 1e7; i++) {
      if ((new Date().getTime() - start) > milliseconds) {
        break;
      }
    }
  }
}
