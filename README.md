# DatabaseViewerTemplate
Template for creating DatabaseViewer

1) Populate entity framework models and context using entity framework 
	- dotnet ef dbcontext scaffold "Data Source=.\SQL_2019;Initial Catalog={DatabaseName};Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer --project DatabaseViewerTemplate --schema dbo
	- Update sqlConnection in program.cs (ideally make configurable)
2) Update DBService and IDBService to return data required from database.
3) Create homepage using retrieved data (or it's child) passed into DetailsPopup or TablePopup
