import { TestBed } from '@angular/core/testing';

import { BrandResolveService } from './brand-resolve.service';

describe('BrandResolveService', () => {
  let service: BrandResolveService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BrandResolveService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
