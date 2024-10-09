import socket

# Create a TCP/IP socket
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Bind the socket to the port
server_address = ('localhost', 65432)  # IP address and Port
server_socket.bind(server_address)

# Listen for incoming connections
server_socket.listen(1)
print('Waiting for a connection...')

while True:
    # Wait for a connection
    connection, client_address = server_socket.accept()
    try:
        print(f'Connection from {client_address}')

        # Receive the data in small chunks and send a response back
        while True:
            data = connection.recv(1024)
            if data:
                print(f'Received: {data.decode("utf-8")}')
                # Send data back to the client
                response = f'{data.decode("utf-8")}'
                connection.sendall(response.encode('utf-8'))
            else:
                # Break the loop when there's no more data
                break

    finally:
        # Clean up the connection
        connection.close()
