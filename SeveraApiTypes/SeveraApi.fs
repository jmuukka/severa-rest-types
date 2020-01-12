namespace Mutex.Visma.Severa

module API =

    open SwaggerProvider

    let [<Literal>] Schema = "https://severa.visma.com/PSARest/restapidoc/docs/v0.2"

    type InternalApi = SwaggerClientProvider<Schema, PreferAsync=true, IgnoreControllerPrefix=false>
