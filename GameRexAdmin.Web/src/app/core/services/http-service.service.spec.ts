import { TestBed, inject } from '@angular/core/testing';
import { HttpService } from './http-service.service';
import { HttpClientModule } from '@angular/common/http';

describe('HttpServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HttpServiceService]
    });
  });

  it('should be created', inject([HttpServiceService], (service: HttpClientModule) => {
    expect(service).toBeTruthy();
  }));
});
