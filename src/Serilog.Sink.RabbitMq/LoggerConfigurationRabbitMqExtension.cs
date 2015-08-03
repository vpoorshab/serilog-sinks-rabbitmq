﻿using System;
using Serilog.Configuration;
using Serilog.Sinks.RabbitMq;
using Serilog.Sinks.RabbitMq.Sinks.RabbitMq;

namespace Serilog
{
    /// <summary>
    /// Extension method to configure Serilog with a Sink for RabbitMq
    /// </summary>
    public static class LoggerConfigurationRabbitMqExtension
    {
        /// <summary>
        /// Adds a sink that lets you push log messages to RabbitMq
        /// </summary>
        /// <param name="loggerConfiguration"></param>
        /// <param name="rabbitMqConfiguration">Mandatory RabbitMq configuration</param>
        /// <param name="formatProvider">Optional formatProvider. If not specified, then default is 'null'</param>
        /// <returns></returns>
        public static LoggerConfiguration RabbitMq(
            this LoggerSinkConfiguration loggerConfiguration,
            RabbitMqConfiguration rabbitMqConfiguration,
            IFormatProvider formatProvider = null)
        {
            if (loggerConfiguration == null) throw new ArgumentNullException("loggerConfiguration");
            return
                loggerConfiguration
                    .Sink(new RabbitMqSink(rabbitMqConfiguration, formatProvider));
        }
    }
}
