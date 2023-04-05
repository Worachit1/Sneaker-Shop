```mermaid
classDiagram
 direction LR
 class Form1{
 -product():void
 -member():void
 -pay():void
 -Save():void
 -Open():void
}
 class Pay{
 -pay():void
 -Exit():void
 }
 class Login{
 -member.double
 +getMem():void
 }
 class Product{
 +Bitmap getImage():void
 +string getName():void
 +int getPrice():void
  }
  class AJonexOffWhite{
  + AJonexOffWhite():void
  }
  class AZPegasus39{
  + AZPegasus39():void
  }
  class PG3NASA{
  + PG3NASA():void
  }
  class WhyNotZ4{
  + WhyNotZ4():void
  }
  Form1 -- Login
  Product -- AJonexOffWhite
  Product -- AZPegasus39
  Product -- PG3NASA
  Product -- WhyNotZ4
  ```

 
