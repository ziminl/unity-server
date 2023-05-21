import socket

SERVER_IP = '127.0.0.1'
SERVER_PORT = 5050
SIZE = 1024
SERVER_ADDR = (SERVER_IP, SERVER_PORT)

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as client_socket:
    client_socket.connect(SERVER_ADDR)  
    client_socket.send('hi'.encode())  
    msg = client_socket.recv(SIZE) 
    print("resp from server : {}".format(msg))