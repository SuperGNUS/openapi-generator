# NOTE: This file is auto generated by OpenAPI Generator 6.6.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule OpenapiPetstore.Model.NumberOnly do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :JustNumber
  ]

  @type t :: %__MODULE__{
    :JustNumber => float() | nil
  }
end

defimpl Poison.Decoder, for: OpenapiPetstore.Model.NumberOnly do
  def decode(value, _options) do
    value
  end
end

