# LocalizationJsonFileToResx
## This small windows form converts a localization json file (Key and value) to resx file 

#### Json file template : 
```code
{
  "LOGIN": "تسجيل دخول",
  "LOGGIN": "الدخول",
  "SELECT_AREA": "أختر المنطقة",
  "SELECT_COMPANY": "أختر الشركة",
  "SELECT_BRANCH": "أختر الفرع",
  "SELECT_LANGUAGE": "أختر الغة",
  "ENTER_USERCODE": "أدخل كود المستخدم",
  ...
  ...
  ...
  ...
  }
```


#### resx file output : 
```code
<data name="LOGIN" xml:space="preserve">
	<value>تسجيل دخول</value>
</data>
<data name="LOGGIN" xml:space="preserve">
	<value>الدخول</value>
</data>
<data name="SELECT_AREA" xml:space="preserve">
	<value>أختر المنطقة</value>
</data>
<data name="SELECT_COMPANY" xml:space="preserve">
	<value>أختر الشركة</value>
</data>
<data name="SELECT_BRANCH" xml:space="preserve">
	<value>أختر الفرع</value>
</data>
<data name="SELECT_LANGUAGE" xml:space="preserve">
	<value>أختر الغة</value>
</data>
<data name="ENTER_USERCODE" xml:space="preserve">
	<value>أدخل كود المستخدم</value>
</data>
  ...
  ...
  ...
```


### ScreenShot :
##### Customizing : 

![image](https://user-images.githubusercontent.com/10328974/208312822-a5afcbad-42db-446c-97b4-48a31fefd829.png)


##### Result :
![image](https://user-images.githubusercontent.com/10328974/208312837-6ec9c4f8-3740-4008-b179-78609f6035e8.png)

