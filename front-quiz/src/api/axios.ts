import axios from "axios";
import Cookies from "js-cookie";
import { API_URL } from "./api.constants";

export const api = axios.create({
  baseURL: API_URL,
  withCredentials: true,
});

api.interceptors.request.use((config) => {
  const accessToken = Cookies.get("access_token");
  if (config.headers && accessToken) {
    config.headers.Authorization = `Bearer ${accessToken}`;
  }

  return config;
});
