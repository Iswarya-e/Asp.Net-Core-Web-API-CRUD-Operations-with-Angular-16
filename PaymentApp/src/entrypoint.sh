#!/bin/sh
envsubst < /usr/share/nginx/html/assets/env.js > /usr/share/nginx/html/assets/env.generated.js
mv /usr/share/nginx/html/assets/env.generated.js /usr/share/nginx/html/assets/env.js
exec "$@"
