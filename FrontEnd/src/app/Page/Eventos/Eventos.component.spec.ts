/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Lista_EventosComponent } from './Lista_Eventos.component';

describe('EventosComponent', () => {
  let component: Lista_EventosComponent;
  let fixture: ComponentFixture<Lista_EventosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Lista_EventosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Lista_EventosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
