import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';


// "MongoConnectionString": "mongodb://myserv:SKiEI6tRk55K4r3dwUCF5viVEWZmJsSJ9lUVHUM1xgVRuoGQqilhCTqquOPSPyaw7x7DUAen5f4eACDbs9d9Vg==@myserv.mongo.cosmos.azure.com:10244/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@myserv@"

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
