

import { Component } from "@angular/core"
@Component({
    selector: 'my-app',
    templateUrl:'app/app.component.html'    
})




export class AppComponent {
    pagename: string = "Employee Details";
    imagePath: string = "https://www.uhcl.edu/images/header-promos/students-hawks-letters.jpg";

    getDetails(): string {
        return this.pagename + this.imagePath;
    }
}
