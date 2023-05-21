import socket

IP = '127.0.0.1'
PORT = 5050
SIZE = 1024
ADDR = (IP, PORT)

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as server_socket:
    server_socket.bind(ADDR)  
    server_socket.listen()  

    while True:
        client_socket, client_addr = server_socket.accept() 
        msg = client_socket.recv(SIZE) 
        print("[{}] message : {}".format(client_addr,msg)) 
        
        client_socket.sendall("welcome!".encode()) 
        client_socket.close() 
