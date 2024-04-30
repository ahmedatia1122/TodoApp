import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'TodoApplication',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44394/',
    redirectUri: baseUrl,
    clientId: 'TodoApplication_App',
    responseType: 'code',
    scope: 'offline_access TodoApplication',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44394',
      rootNamespace: 'TodoApplication',
    },
  },
} as Environment;
