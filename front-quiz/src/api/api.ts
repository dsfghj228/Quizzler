import Cookies from "js-cookie";
import {
  loginRequest,
  loginResponse,
  registerRequest,
} from "../types/apiAuth.types";
import { api } from "./axios";

//////////////////////////AUTHENTICATION///////////////////////////////

export const login = async (data: loginRequest): Promise<loginResponse> => {
  try {
    const response = await api.post<loginResponse>("/account/login", data);
    const fifteenMinutes = 15 / (60 * 24);
    Cookies.set("access_token", response.data.token, {
      expires: fifteenMinutes,
    });
    return response.data;
  } catch (error: any) {
    console.error(error.response?.data || error.message);
    throw error;
  }
};

export const register = async (data: registerRequest): Promise<void> => {
  try {
    await api.post<void>("/account/register", data);
  } catch (error: any) {
    console.error(error.response?.data || error.message);
    throw error;
  }
};
