import { dotnet } from './_framework/dotnet.js'

await dotnet
  .withDebugging(1)
  .withDiagnosticTracing(false)
  .withApplicationArgumentsFromQuery()
  .create();

dotnet.instance.Module['canvas'] = document.getElementById('canvas');
await dotnet.run();
