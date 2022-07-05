/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { VisitanteService } from './Visitante.service';

describe('Service: Visitante', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [VisitanteService]
    });
  });

  it('should ...', inject([VisitanteService], (service: VisitanteService) => {
    expect(service).toBeTruthy();
  }));
});
