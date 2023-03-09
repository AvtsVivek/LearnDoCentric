# Getting Started.

1. Go [here to the download page](https://www.docentric.com/download)

![Installation exe](./images/20InstallationExeDownloaded20.jpg)


2. Once installed, you should be able to run the Example Browser

![Example Browser](./images/20ExBrowser30.jpg)

3. Also when you open ms word, you should be see do centric tool kit.

![Docentric tool kit ](./images/20DocentricToolkitMsWord40.jpg)

# Now time to create a template. Follow the steps.

1. Create a new blank word document. Then ensure Main Menu -> Docentric Toolkit -> Use As Template is selected. See the above image.

2. Add a new Data Source by clicking the Add button and giving it a name.

![Click to add a data source ](./images/20AddingDataSource50.jpg)

3. Now to add a schema click the button as follows. Then select a dll as follows.

![Click to add a data source schema ](./images/20AddingDataSource50.jpg)

4. Select a dll. 

![Select an assembly ](./images/20AddingSchemaDataSource60.jpg)

5. The dll must be produced by a dotnet standard 2.0 project such as follows.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <Nullable>enable</Nullable>
	<LangVersion>11.0</LangVersion>
  </PropertyGroup>

</Project>

```

6. Select a type

![Select an assembly ](./images/20TypeSelection70.jpg)

7. Binding a source to field

![Select an assembly ](./images/20BindingFieldsToSources80.jpg)

8. Now run the app.