import { TestBed, inject } from '@angular/core/testing';

import { GiantBombApiImportService } from './giant-bomb-api-import.service';

describe('GiantBombApiImportService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [GiantBombApiImportService]
    });
  });

  it('should be created', inject([GiantBombApiImportService], (service: GiantBombApiImportService) => {
    expect(service).toBeTruthy();
  }));
});
