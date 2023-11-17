import { Component } from '@angular/core';
import { NumtowordsService } from '../services/numtowords.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-word',
  templateUrl: './word.component.html',
  styleUrls: ['./word.component.css'],
})
export class WordComponent {
  num: Number = 0;
  wordsResult: string = '';

  constructor(
    private numtowordsService: NumtowordsService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.num = Number(this.route.snapshot.paramMap.get('num'));

    this.numtowordsService.getWords(this.num).subscribe((words) => {
      console.log(words);
      this.wordsResult = words.result as string;
    });
  }
}
