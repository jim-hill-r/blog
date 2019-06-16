My recent vigor for decoupling client-side code from server side APIs has led me to researching Blazor. It has all the potential to allow both back-end and front-end code to run on .NET. With that (combined with my normal DevOps focus), I decided to see what I would take to launch a client-side Blazor app on Azure using static CDN hosting. Overall it went pretty well. Here are the steps I took and some of the problems summarized.

- How to set up an Azure Storage account for static hosting
  - **Hurdle debt**: I wanted many sites hosted on one storage account. Succeeded but only while suffering index.html rerouting woahs.
- How to set up an Azure CDN to distribute static Storage content
  - **Hurdle debt**: Did not get index.html rerouting sorted.
- How to set up a Google Domains DNS to the Azure CDN
- How to create an Azure DevOps build pipeline for Blazor
  - **Hurdle overcome**: How to get preview builds to work.
- How to create an Azure DevOps release pipeline for Azure CDN/Blazor
  - **Hurdle overcome**: How to get WASM files to copy properly