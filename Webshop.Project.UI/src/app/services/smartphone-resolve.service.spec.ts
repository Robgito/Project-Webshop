import { TestBed } from '@angular/core/testing';

import { SmartphoneResolveService } from './smartphone-resolve.service';

describe('SmartphoneResolveService', () => {
  let service: SmartphoneResolveService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SmartphoneResolveService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
