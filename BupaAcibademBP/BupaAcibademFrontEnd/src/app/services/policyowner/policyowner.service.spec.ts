import { TestBed } from '@angular/core/testing';

import { PolicyOwnerService } from './policyowner.service';

describe('PolicyownerService', () => {
  let service: PolicyOwnerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PolicyOwnerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
