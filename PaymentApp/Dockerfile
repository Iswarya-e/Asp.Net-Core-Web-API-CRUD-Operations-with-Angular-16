FROM node:20-alpine as build
WORKDIR /app
COPY package*.json ./

RUN npm install
COPY . .
RUN npm run build --prod

FROM nginx:alpine
COPY --from=build /app/dist/payment-app /usr/share/nginx/html
COPY src/assets/env.js /usr/share/nginx/html/assets/env.js
COPY src/entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh

ENTRYPOINT ["/entrypoint.sh"]

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
