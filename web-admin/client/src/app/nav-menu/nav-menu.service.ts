import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Menu } from './nav-menu.model';

@Injectable({
  providedIn: 'root',
})
export class NavMenuService {
  private menu: Menu | null = null;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Menu>(baseUrl + '/global/menu')
      .subscribe({
        next: (result) => this.menu = result,
        error: (error) => console.log(error),
      });
  }

  get Menu(): Menu | null {
    return this.menu;
  }
}
