import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ImportPlatformComponent } from './import-platform.component';

describe('ImportPlatformComponent', () => {
  let component: ImportPlatformComponent;
  let fixture: ComponentFixture<ImportPlatformComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ImportPlatformComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ImportPlatformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
