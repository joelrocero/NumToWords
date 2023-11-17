import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-number',
  templateUrl: './number.component.html',
  styleUrls: ['./number.component.css'],
})
export class NumberComponent {
  enteredNumber: Number = 0;

  constructor(private router: Router) {}

  onConvert(form: NgForm) {
    if (form.invalid) {
      return;
    }
    this.router.navigate(['word/' + form.value.enteredNumber]);
    console.log(form.value);
  }
}
