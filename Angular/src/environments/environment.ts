import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Grumium',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44315',
    redirectUri: baseUrl,
    clientId: 'Grumium_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone Grumium',
  },
  apis: {
    default: {
      url: 'https://localhost:44398',
      rootNamespace: 'OrgAE.Grumium',
    },
  },
} as Environment;
