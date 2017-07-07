# PCF .NET Startup Process Example

This repo contains an example solution for having a startup process run before your app starts.

## Building
1. Build the solution in Visual Studio.
2. Publish the `SampleSite` project using the `PublishDir` profile.

## Deploying

### PCF <v1.10
From the `publish` directory under the PCFStartupProcessExample solution:
```
cf push
```

### PCF >=v1.10
From the `publish` directory under the PCFStartupProcessExample solution:
```
cf push -f manifest-v1.10.yml
```