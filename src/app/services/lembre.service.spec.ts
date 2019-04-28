import { TestBed } from '@angular/core/testing';

import { LembreService } from './lembre.service';

describe('LembreService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LembreService = TestBed.get(LembreService);
    expect(service).toBeTruthy();
  });
});
