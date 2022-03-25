# Migrations


## Creating Migration Scripts

* In Visual Studio, Click on the Tools -> Nuget Package Manager -> Package Manager Console
* First migration run the following

```bash
Add-Migration InitialMigration
```

* Verify migrations scripts are run successfully and Migrations folder is created

## Running Migrations Scripts

To run the migration, again open up the Package Manager Console and run the following:

```bash
Update-Database
```

