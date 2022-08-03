# API Compras

- [API Compras](#api-compras)
  - [Create Compra](#create-compra)
    - [Create Compra Request](#create-compra-request)
    - [Create Compra Response](#create-compra-response)
  - [Get Compra](#get-compra)
    - [Get Compra Request](#get-compra-request)
    - [Get Compra Response](#get-compra-response)
  - [Update Compra](#update-compra)
    - [Update Compra Request](#update-compra-request)
    - [Update Compra Response](#update-compra-response)
  - [Delete Compra](#delete-compra)
    - [Delete Compra Request](#delete-compra-request)
    - [Delete Compra Response](#delete-compra-response)

## Create Compra

### Create Compra Request

```js
POST /compras
```

```json
{
    "cliente_id": 7,
    "fecha": "2022-08-03T16:49:00",
    "metodo_pago": "2022-04-08T11:00:00",
    "estado": "pendiente"
}
```

### Create Compra Response

```js
201 Created
```

```yml
Location: {{host}}/Compras/{{id}}
```

```json
{
    "compra_id": 3,
    "cliente_id": 7,
    "fecha": "2022-08-03T16:49:00",
    "metodo_pago": "2022-04-08T11:00:00",
    "estado": "pendiente"
}
```

## Get Compra

### Get Compra Request

```js
GET /compras/{{id}}
```

### Get Compra Response

```js
200 Ok
```

```json
{
    "compra_id": 3,
    "cliente_id": 7,
    "fecha": "2022-08-03T16:49:00",
    "metodo_pago": "2022-04-08T11:00:00",
    "estado": "pendiente"
}
```

## Update Compra

### Update Compra Request

```js
PUT /compras/{{id}}
```

```json
{
    "cliente_id": 7,
    "fecha": "2022-08-03T16:49:00",
    "metodo_pago": "2022-04-08T11:00:00",
    "estado": "pendiente"
}
```

### Update Compra Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Compras/{{id}}
```

## Delete Compra

### Delete Compra Request

```js
DELETE /compras/{{id}}
```

### Delete Compra Response

```js
204 No Content
```