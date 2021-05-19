import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { MessagesComponent } from './messages/messages.component';
import { HttpClientModule } from '@angular/common/http';
import { NavigationBarComponent } from './pages/page-components/navigation-bar/navigation-bar.component';
import { TitleComponent } from './pages/page-components/title/title.component';
import { TitleCircleComponent } from './pages/page-components/title-circle/title-circle.component';
import { TitleTextComponent } from './pages/page-components/title-text/title-text.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { MenuPageComponent } from './pages/menu-page/menu-page.component';
import { MissionPageComponent } from './pages/mission-page/mission-page.component';
import { ReservePageComponent } from './pages/reserve-page/reserve-page.component';
import { ChefsPageComponent } from './pages/chefs-page/chefs-page.component';
import { SignUpPageComponent } from './pages/sign-up-page/sign-up-page.component';
import { SignInPageComponent } from './pages/sign-in-page/sign-in-page.component';
import { ContactPageComponent } from './pages/contact-page/contact-page.component';

@NgModule({
  declarations: [
    AppComponent,
    MessagesComponent,
    NavigationBarComponent,
    TitleComponent,
    TitleCircleComponent,
    TitleTextComponent,
    HomePageComponent,
    MenuPageComponent,
    MissionPageComponent,
    ReservePageComponent,
    ChefsPageComponent,
    SignUpPageComponent,
    SignInPageComponent,
    ContactPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
