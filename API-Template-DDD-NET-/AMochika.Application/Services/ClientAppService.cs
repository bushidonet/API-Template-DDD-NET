﻿using AMochika.Core.Services;

namespace AMochika.Application;

public class ClientAppService
{
    private readonly ClientService _clientService;

    public ClientAppService(ClientService clientService)
    {
        _clientService = clientService;
    }

    public async Task<bool> ValidateMonthlyPaymentAsync(int clientId)
    {
        return await _clientService.ValidateMonthlyPayment(clientId);
    }
}