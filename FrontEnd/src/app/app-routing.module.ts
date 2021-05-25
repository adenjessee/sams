
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomePageComponent } from './pages/home-page/home-page.component';
import { MenuPageComponent } from './pages/menu-page/menu-page.component';
import { MissionPageComponent } from './pages/mission-page/mission-page.component';
import { ReservePageComponent } from './pages/reserve-page/reserve-page.component';
import { ChefsPageComponent } from './pages/chefs-page/chefs-page.component';
import { SignUpPageComponent } from './pages/sign-up-page/sign-up-page.component';
import { SignInPageComponent } from './pages/sign-in-page/sign-in-page.component';
import { ContactPageComponent } from './pages/contact-page/contact-page.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomePageComponent },
  { path: 'menu', component: MenuPageComponent },
  { path: 'mission', component: MissionPageComponent },
  { path: 'reserve', component: ReservePageComponent },
  { path: 'chefs', component: ChefsPageComponent },
  { path: 'sign-up', component: SignUpPageComponent },
  { path: 'sign-in', component: SignInPageComponent },
  { path: 'contact', component: ContactPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
