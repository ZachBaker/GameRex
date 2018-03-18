import { TestBed, inject } from '@angular/core/testing';

import { SleepService } from './sleep.service';

describe('SleepService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SleepService]
    });
  });

  it('should be created', inject([SleepService], (service: SleepService) => {
    expect(service).toBeTruthy();
  }));
});
