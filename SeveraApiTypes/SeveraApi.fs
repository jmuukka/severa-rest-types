namespace Mutex.Visma.Severa

module API =

    open SwaggerProvider

    let [<Literal>] Schema = "https://publicrest.severa.visma.com/PSAPublicRest/RestApiDoc/docs/v0.1"

    type ApiTypes = SwaggerClientProvider<Schema, PreferAsync=true>
