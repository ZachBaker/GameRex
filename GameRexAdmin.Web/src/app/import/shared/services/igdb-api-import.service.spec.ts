import { TestBed, inject } from '@angular/core/testing';

import { IgdbApiImportService } from './igdb-api-import.service';

describe('IgdbApiImportService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [IgdbApiImportService]
    });
  });

  it('should be created', inject([IgdbApiImportService], (service: IgdbApiImportService) => {
    expect(service).toBeTruthy();
  }));
});
