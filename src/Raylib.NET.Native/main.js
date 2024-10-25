import { dotnet } from './_framework/dotnet.js'

await dotnet
  .withModuleConfig({ 'canvas': document.getElementById('canvas') })
  .withDebugging(1)
  .withDiagnosticTracing(false)
  .withApplicationArgumentsFromQuery()
  .create();

await dotnet.run();
