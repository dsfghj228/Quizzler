export interface loginRequest {
  username: string;
  password: string;
}

export interface loginResponse {
  userName: string;
  email: string;
  token: string;
}
