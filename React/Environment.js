const ENV = {
  dev: {
    apiUrl: 'http://localhost:44337',
    oAuthConfig: {
      issuer: 'http://localhost:44382',
      clientId: 'Grumium_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Grumium',
    },
    localization: {
      defaultResourceName: 'Grumium',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44337',
    oAuthConfig: {
      issuer: 'http://localhost:44382',
      clientId: 'Grumium_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Grumium',
    },
    localization: {
      defaultResourceName: 'Grumium',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
