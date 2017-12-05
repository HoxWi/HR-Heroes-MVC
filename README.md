# HR-Heroes-MVC
.NET MVC Sample

Please note that any data stored during this alpha period could be removed at any time due to techinical changes.

Please add this settings to your app settings or Web.Config file in order to make your client work:

    <add key="DefaultHoxDbSvcUrl" value="https://hoxwi.com"/>
    <add key="HoxDbApiSecret" value="YOUR-SECRET-KEY"/>
    <add key="DefaultHoxDbMode " value="Dynamic"/>

Before start using this component please create your account, it is completely free for up to a certain amount of transactions/month.

To create your account go to www.hoxwi.com or perform a single call (using postman for sample), as demonstrated bellow:

PUT: https://www.hoxwi.com/Wi/NewAccount

Type: application/json

Body: 
{
  "name":"Your Name",
  "email": "Your Email",
}

Then save the result carefully as it is your passport for the platform:

{
  "readyToUse": true,
  "secretkey": "xyz secret key value",
  "message": "Please save your secret key. It is your passport to access your services."
}

Live sample at http://hoxwimvcsample.azurewebsites.net/
