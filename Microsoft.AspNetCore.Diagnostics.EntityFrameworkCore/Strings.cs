using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
{
    public static class Strings
    {
        public static string DatabaseErrorPage_Title = "A database operation failed while processing the request.";

        public static string FormatDatabaseErrorPage_NoDbOrMigrationsTitle(string str) => $"Use migrations to create the database for {str}";

        public static string DatabaseErrorPage_NoDbOrMigrationsInfoPMC = "In Visual Studio, use the Package Manager Console to scaffold a new migration and apply it to the database:";

        public static string DatabaseErrorPage_AddMigrationCommandPMC = "PM> Add-Migration [migration name]";

        public static string DatabaseErrorPage_ApplyMigrationsCommandPMC = "PM> Update-Database";


        public static string DatabaseErrorPage_NoDbOrMigrationsInfoCLI = "Alternatively, you can scaffold a new migration and apply it from a command prompt at your project directory:";

        public static string DatabaseErrorPage_AddMigrationCommandCLI = "> dotnet ef migrations add [migration name]";

        public static string DatabaseErrorPage_ApplyMigrationsCommandCLI = "> dotnet ef database update";

        public static string FormatDatabaseErrorPage_PendingMigrationsTitle(string str) => $"Applying existing migrations for {str} may resolve this issue";

        public static string FormatDatabaseErrorPage_PendingMigrationsInfo(string str) => $"There are migrations for {str} that have not been applied to the database";

        public static string DatabaseErrorPage_ApplyMigrationsButton = "Apply Migrations";

        public static string DatabaseErrorPage_ApplyMigrationsButtonRunning = "Applying Migrations...";

        public static string DatabaseErrorPage_ApplyMigrationsButtonDone = "Migrations Applied";

        public static string DatabaseErrorPage_MigrationsAppliedRefresh = "Try refreshing the page";

        public static string DatabaseErrorPage_ApplyMigrationsFailed = "An error occurred applying migrations, try applying them from the command line";

        public static string DatabaseErrorPage_HowToApplyFromPMC = "In Visual Studio, you can use the Package Manager Console to apply pending migrations to the database:";

        public static string DatabaseErrorPage_HowToApplyFromCLI = "Alternatively, you can scaffold a new migration and apply it from a command prompt at your project directory:";

        public static string FormatDatabaseErrorPage_PendingChangesTitle(string str) => $"There are pending model changes for {str}";

        public static string DatabaseErrorPage_PendingChangesInfoPMC = "In Visual Studio, use the Package Manager Console to scaffold a new migration for these changes and apply them to the database:";

        public static string DatabaseErrorPage_PendingChangesInfoCLI = "Alternatively, you can scaffold a new migration and apply it from a command prompt at your project directory:";

        public static string FormatMigrationsEndPointMiddleware_Exception(string str) => $"An error occurred while applying the migrations for '{str}'. See InnerException for details.";

        public static string MigrationsEndPointMiddleware_NoContextType = "No context type was specified. Ensure the form data from the request includes a 'context' value, specifying the context type name to apply migrations for.";

        public static string FormatMigrationsEndPointMiddleware_InvalidContextType(string str) => $"The context type '{str}' could not be loaded. Ensure this is the correct type name for the context you are trying to apply migrations for.";

        public static string FormatMigrationsEndPointMiddleware_ContextNotRegistered(string str) => $"The context type '{str}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped<{str}>() inside the UseServices(...) call in your application startup code.";
    }
}
