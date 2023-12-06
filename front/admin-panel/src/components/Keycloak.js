import Keycloak from "keycloak-js";

const keycloakClient = new Keycloak({
    url: "http://localhost:8080",
    realm: "bdiscount",
    clientId: "panel_admin",
})

export default keycloakClient;
