# Tamtom.Application

set application base info once and use it

## Install
Use npm to install:

```
npm install Tamtom.Application@latest --save
```

</hr>

## Startup.cs


```
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
#if DEBUG
            Tamtom.Application.DataAccess.Initialize(".", "DatabaseName", "DatabaseUser", "DatabasePassword");
            Tamtom.Application.URI.Initialize("https", "localhost:44375");
#else
            Tamtom.Application.DataAccess.Initialize(".", "DatabaseName", "DatabaseUser", "DatabasePassword");
            Tamtom.Application.URI.Initialize("https", "www.Website.com");
#endif
        }
```

# <h3>Use</h3>

```
using static Tamtom.Application.DataAccess;
using static Tamtom.Application.URI;

namespace MyProjectNamespace
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine(ConnectionString); // "Server=.;Database=DatabaseName;User Id=DatabaseUser;Password=DatabasePassword;"
            Console.WriteLine(URL); // "https://localhost:44375"
        }
    }
}
```
